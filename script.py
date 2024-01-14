# coding: iso-8859-1 -*-
# -*- encoding: utf-8 -*-
import os
import shutil
import subprocess
import tempfile
import git

def get_remote_url(repo):
    remote_url = "https://github.com/alkrynax/RomanNmbrsCS.git"  # Assure-toi que "origin" est le nom de ton remote
    return remote_url

def clone_repo(remote_url, temp_dir):
    repo_clone_path = os.path.join(temp_dir, "repo_clone")
    subprocess.run(["git", "clone", remote_url, repo_clone_path])
    return repo_clone_path

def run_tests(tests_csproj_path):
    command = f"dotnet test {tests_csproj_path} --filter Category!=Integration"
    result = subprocess.run(command, shell=True)
    return result.returncode

def push_changes(repo_clone_path):
    repo_clone = git.Repo(repo_clone_path)

    if run_tests(repo_clone_path) == 0:
        repo_clone.git.add(all=True)
        repo_clone.index.commit("Commit message from Python script")

        try:
            origin = repo_clone.remote(name="origin")  # Assure-toi que "origin" est le nom de ton remote
            origin.push()
            return "push"
        except Exception as error:
            print(error)
            repo_clone.head.reset('HEAD~1', index=True, working_tree=True)
            return "Commit unset"
    else:
        return "Tests must pass before commit!"

def cleanup_temp(temp_dir):
    shutil.rmtree(temp_dir)

def main():
    repo_folder = "/Users/Lelia/source/repos/RomanNmbrsCS"
    tests_csproj_path = "/Users/Lelia/source/repos/RomanNmbrsCS"

    actual_repo = git.Repo(repo_folder)
    remote_url = get_remote_url(actual_repo)

    # Créer un dossier temporaire
    with tempfile.TemporaryDirectory() as temp_dir:
        # Cloner le repo dans le dossier temporaire
        repo_clone_path = clone_repo(remote_url, temp_dir)

        # Effectuer les opérations nécessaires dans le dossier temporaire
        result = push_changes(repo_clone_path)

        # Nettoyer le dossier temporaire
        cleanup_temp(temp_dir)

        print(result)

if __name__ == "__main__":
    main()