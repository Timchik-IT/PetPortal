module Projects
  class Create
    include Interactor::Organizer

    delegate :project, to: :context

    organize Projects::Save
  end
end
